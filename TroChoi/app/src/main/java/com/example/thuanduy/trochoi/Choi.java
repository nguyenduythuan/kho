package com.example.thuanduy.trochoi;

import android.content.Intent;
import android.content.SharedPreferences;
import android.media.MediaPlayer;
import android.os.CountDownTimer;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.ImageView;
import android.widget.TableLayout;
import android.widget.TableRow;
import android.widget.TextView;
import android.widget.Toast;

import java.util.ArrayList;
import java.util.Collections;
import java.util.Random;

public class Choi extends AppCompatActivity {
    TableLayout myTable ;
    ArrayList<String> ten;
    TextView tvH,txtDiem,nhacnho;
    int total = 100;
    int a=2;
    SharedPreferences luudiem;
    MediaPlayer mediaPlayer;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_choi);
            luudiem=getSharedPreferences("Diemgame",MODE_APPEND);
            myTable = (TableLayout) findViewById(R.id.tableIMG);
            tvH = (TextView) findViewById(R.id.TenHinh);
            nhacnho=(TextView) findViewById(R.id.nhacnho);
            nhacnho.setText("n_n n_n");
            txtDiem = (TextView) findViewById(R.id.textDiem);
            total=luudiem.getInt("diem",100);
            txtDiem.setText(total+"");
            /////
            ten = new ArrayList<>();
            int SoDong = 3;
            int SoCot = 2;
            Collections.shuffle(menutrochoi.arrayname);
            //Tạo dòng và cột
            for (int i = 1; i <= SoDong; i++) {
                TableRow tableRow = new TableRow(this);
                //Tao cot
                for (int j = 1; j <= SoCot; j++) {
                    ImageView imageView = new ImageView(this);
                    TableRow.LayoutParams layoutParams = new TableRow.LayoutParams(300, 300);
                    imageView.setLayoutParams(layoutParams);

                    final int vitri = SoCot * (i - 1) + j - 1;
                    int idHinh = getResources().getIdentifier(menutrochoi.arrayname.get(vitri), "drawable", getPackageName());
                    imageView.setImageResource(idHinh);
                    // add IMG
                    tableRow.addView(imageView);

                    imageView.setOnClickListener(new View.OnClickListener() {
                        @Override
                        public void onClick(View v) {
                            if (tvH.getText().equals(menutrochoi.arrayname.get(vitri))) {
                                //Cộng điểm
                                mediaPlayer = MediaPlayer.create(Choi.this,R.raw.totlam);
                                mediaPlayer.start();
                                total+=5;
                                LuuDiem();
                                Collections.shuffle(menutrochoi.arrayname);
                                startActivity(new Intent(Choi.this ,Choi.class));
                                new CountDownTimer(200, 100) {
                                    @Override
                                    public void onTick(long millisUntilFinished) {

                                    }

                                    @Override
                                    public void onFinish() {
                                        finish();
                                    }
                                }.start();
                            }
                            else {
                                    mediaPlayer = MediaPlayer.create(Choi.this,R.raw.sai);
                                    mediaPlayer.start();
                                    total=total-10;
                                    LuuDiem();
                                    txtDiem.setText(total+"");
                                    a--;
                                    nhacnho.setText("@_@ n_n");
                                   if(a==0){
                                    nhacnho.setText("@_@ @_@");
                                    finish();}
                            }
                            //
                        }
                    });
                    ten.add(menutrochoi.arrayname.get(vitri));
                }
                //add dong
                myTable.addView(tableRow);
            }
            Random random = new Random();
            int so = random.nextInt(ten.size());
            tvH.setText(ten.get(so));

        }
        private void LuuDiem(){
            SharedPreferences.Editor editor = luudiem.edit();
            editor.putInt("diem",total);
            editor.commit();
        }
    }


