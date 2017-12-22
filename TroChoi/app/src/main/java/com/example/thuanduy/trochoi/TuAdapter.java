package com.example.thuanduy.trochoi;

import android.content.Context;
import android.media.AudioManager;
import android.media.MediaPlayer;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.ImageView;
import android.widget.TextView;

import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
import java.util.Locale;

/**
 * Created by thuan on 28/11/2017.
 */

public class TuAdapter extends BaseAdapter {
    private Context context;
    private int layout;
    private List<Tu> tuList;
    private ArrayList<Tu> arrayList;

    public TuAdapter(Context context, int layout, List<Tu> tuList) {
        this.context = context;
        this.layout = layout;
        this.tuList = tuList;

        this.arrayList = new ArrayList<Tu>();
        this.arrayList.addAll(tuList);
    }

    @Override
    public int getCount() {
        return tuList.size();
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
        TextView txtTu, txtPhatAm,txtDich;
        ImageView hinh;

    }
    @Override
    public View getView(int i, View view, ViewGroup parent) {
        ViewHolder holder;
        if(view==null) {
            holder = new ViewHolder();
            LayoutInflater inflater = (LayoutInflater) context.getSystemService(Context.LAYOUT_INFLATER_SERVICE);
            view = inflater.inflate(layout, null);
            holder.txtTu = (TextView) view.findViewById(R.id.txtTen);
            holder.txtPhatAm = (TextView) view.findViewById(R.id.txtPhatAm);
            holder.txtDich = (TextView) view.findViewById(R.id.txtDich);
            holder.hinh=(ImageView)view.findViewById(R.id.hinh);
            view.setTag(holder);
        }
        else {
            holder=(ViewHolder) view.getTag();
        }

        final Tu tu= tuList.get(i);
        holder.txtTu.setText(tu.getWord());
        holder.txtPhatAm.setText(tu.getPronounce());
        holder.txtDich.setText(tu.getDetail());
        holder.hinh.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                MediaPlayer mediaplay = new MediaPlayer();
                mediaplay.setAudioStreamType(AudioManager.STREAM_MUSIC);
                try {
                    mediaplay.setDataSource(tu.getLink());
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
        //Bắt sự kiện

        return view;
    }
    public void filter(String charText){
        charText =  charText.toLowerCase(Locale.getDefault());
        tuList.clear();
        if(charText.length()==0){
                tuList.addAll(arrayList);
        }
        else {
            for(Tu tv:arrayList){
                if(tv.getWord().toLowerCase(Locale.getDefault()).contains(charText)){
                    tuList.add(tv);
                }
            }
        }
        notifyDataSetChanged();

    }
}
