package com.example.thuanduy.trochoi;

import android.content.Intent;
import android.media.MediaPlayer;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.GridView;
import android.widget.ImageView;

import java.util.ArrayList;

public class MainActivity extends AppCompatActivity {
    Button TD,TV, TC,CD;
    public static MediaPlayer mediaPlayer;
    public static int tieng = 1;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        AnhXA();
        mediaPlayer = MediaPlayer.create(this,R.raw.nhacnen);
        mediaPlayer.start();
        TD.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(MainActivity.this, Mainsearch.class);
                startActivity(intent);

            }
        });
        TV.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(MainActivity.this, MenuTuVung.class);
                startActivity(intent);

            }
        });
        TC.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(MainActivity.this, menutrochoi.class);
                startActivity(intent);
                mediaPlayer.stop();
            }
        });
        CD.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                if(tieng==1){
                    TD.setText("Từ Điển");
                    TV.setText("Từ vựng hình ảnh");
                    TC.setText("Trò chơi");
                    CD.setText("Ngôn ngữ (E/V)");
                    tieng++;
                }
                else
                {
                    TD.setText("Dictionary");
                    TV.setText("Vocabulary picture");
                    TC.setText("Game");
                    CD.setText("Language(V/E)");
                    tieng--;
                }
            }
        });


    }
    private void AnhXA(){
        TD = (Button) findViewById(R.id.btnTuDien);
        TV = (Button) findViewById(R.id.btnTuVung);
        TC = (Button) findViewById(R.id.btnTroChoi);
        CD = (Button) findViewById(R.id.btnCaiDat);
    }

}
