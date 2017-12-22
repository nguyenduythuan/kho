package com.example.thuanduy.trochoi;

import android.content.Context;
import android.media.AudioManager;
import android.media.MediaPlayer;
import android.support.v7.app.AlertDialog;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.view.animation.Animation;
import android.view.animation.AnimationUtils;
import android.widget.BaseAdapter;
import android.widget.ImageButton;
import android.widget.ImageView;
import android.widget.TextView;
import android.widget.Toast;

import com.squareup.picasso.Picasso;

import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
import java.util.Locale;

/**
 * Created by thuan on 28/11/2017.
 */

public class TuVungAdapter extends BaseAdapter {
    private Context context;
    private int layout;
    private List<TuVung> tuvungList;
    private ArrayList<TuVung> arrayList;

    public TuVungAdapter(Context context, int layout, List<TuVung> tuvungList) {
        this.context = context;
        this.layout = layout;
        this.tuvungList = tuvungList;

        this.arrayList = new ArrayList<TuVung>();
        this.arrayList.addAll(tuvungList);
    }

    @Override
    public int getCount() {
        return tuvungList.size();
    }

    @Override
    public Object getItem(int position) {
        return null;
    }

    @Override
    public long getItemId(int position) {
        return 0;
    }
    private class ViewHolder{
        TextView txtTu, txtPhatAm,txtNghia;
        ImageView Anh;

    }

    @Override
    public View getView(int i, View view, ViewGroup parent) {
        ViewHolder holder;
        if(view==null) {
            holder = new ViewHolder();
            LayoutInflater inflater = (LayoutInflater) context.getSystemService(Context.LAYOUT_INFLATER_SERVICE);
            view = inflater.inflate(layout, null);
            holder.Anh=(ImageView) view.findViewById(R.id.imganh);
            holder.txtTu = (TextView) view.findViewById(R.id.Tu);
            holder.txtPhatAm = (TextView) view.findViewById(R.id.PhatAm);
            holder.txtNghia = (TextView) view.findViewById(R.id.Nghia);
            view.setTag(holder);
        }
        else {
            holder=(TuVungAdapter.ViewHolder) view.getTag();
        }

        final TuVung tuvung= tuvungList.get(i);
        holder.txtTu.setText(tuvung.getTu());
        holder.txtPhatAm.setText(tuvung.getPhatAm());
        holder.txtNghia.setText(tuvung.getNghia());
        Picasso.with(context).load(tuvung.getAnh()).into(holder.Anh);
        //Bắt sự kiện
        holder.Anh.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                //Toast.makeText(context,tuvung.getTieng(),Toast.LENGTH_SHORT).show();
                MediaPlayer mediaplay = new MediaPlayer();
                mediaplay.setAudioStreamType(AudioManager.STREAM_MUSIC);
                try {
                    mediaplay.setDataSource(tuvung.getTieng());
                    mediaplay.prepareAsync();
                    mediaplay.setOnPreparedListener(new MediaPlayer.OnPreparedListener() {
                        @Override
                        public void onPrepared(MediaPlayer mp) {
                            mp.start();
                        }
                    });
                } catch (IOException e) {
                    e.printStackTrace();
                }

            }
        });
        //gan animation
        Animation animation = new AnimationUtils().loadAnimation(context,R.anim.scale_list);
        view.startAnimation(animation);
        return view;
    }
    public void filter(String charText){
        charText =  charText.toLowerCase(Locale.getDefault());
        tuvungList.clear();
        if(charText.length()==0){
            tuvungList.addAll(arrayList);
        }
        else {
            for(TuVung tv:arrayList){
                if(tv.getTu().toLowerCase(Locale.getDefault()).contains(charText)){
                    tuvungList.add(tv);
                }
            }
        }
        notifyDataSetChanged();

    }
}
