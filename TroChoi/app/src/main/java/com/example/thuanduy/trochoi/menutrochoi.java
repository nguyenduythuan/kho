package com.example.thuanduy.trochoi;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;


public class menutrochoi extends AppCompatActivity {
    TextView btchonnguoi,btchonvat,btchonrau,me;
    public static  ArrayList<String> arrayname;
    String[] mangTen;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_menutrochoi);
        anhxa();
        if(MainActivity.tieng==2){
            me.setText("Trò Chơi");
            btchonnguoi.setText("Người và việc làm");
            btchonrau.setText("Rau củ và trái cây");
            btchonvat.setText("Động vật và côn trùng");
        }
        btchonnguoi.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                mangTen = getResources().getStringArray(R.array.list_nguoi);
                arrayname = new ArrayList<>(Arrays.asList(mangTen));
                Intent intent = new Intent(menutrochoi.this, Choi.class);
                startActivity(intent);

            }
        });

        btchonrau.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                mangTen = getResources().getStringArray(R.array.list_rau);
                arrayname = new ArrayList<>(Arrays.asList(mangTen));
                Intent intent = new Intent(menutrochoi.this, Choi.class);
                startActivity(intent);

            }
        });

        btchonvat.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                mangTen = getResources().getStringArray(R.array.list_vat);
                arrayname = new ArrayList<>(Arrays.asList(mangTen));
                Intent intent = new Intent(menutrochoi.this, Choi.class);
                startActivity(intent);
            }
        });
    }
    private void anhxa(){
        btchonnguoi = (TextView) findViewById(R.id.textnguoi);
        btchonvat=(TextView) findViewById(R.id.textvat);
        btchonrau= (TextView) findViewById(R.id.textrau);
        me=(TextView) findViewById(R.id.me);
    }
}
