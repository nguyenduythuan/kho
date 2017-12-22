package com.example.thuanduy.trochoi;

import android.content.Intent;
import android.support.v7.app.AlertDialog;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.support.v7.widget.SearchView;
import android.text.Editable;
import android.text.TextWatcher;
import android.view.Menu;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ListView;
import android.widget.Toast;

import com.android.volley.Request;
import com.android.volley.RequestQueue;
import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.JsonArrayRequest;
import com.android.volley.toolbox.Volley;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import java.util.ArrayList;

public class MainTuVung extends AppCompatActivity implements TextWatcher{
    ListView lvTuVung;
    ArrayList<TuVung> arrayTuvung;
    TuVungAdapter  adapter1;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main_tu_vung);
        MainActivity.mediaPlayer.stop();
        Intent intent = getIntent();
        String urlGetData1  =intent.getStringExtra("url");
        //Toast.makeText(MainTuVung.this, urlGetData1,Toast.LENGTH_SHORT).show();

        lvTuVung =(ListView) findViewById(R.id.LTuVung);
        arrayTuvung = new ArrayList<>();

        GetDataTuVung(urlGetData1);
    }
    private void ThongBao(){
        AlertDialog.Builder alertDialog = new AlertDialog.Builder(this);
        alertDialog.setTitle("Lỗi");
        alertDialog.setMessage("Đã xảy ra lỗi !");
        alertDialog.show();

    }
    private void GetDataTuVung(String url){
        final RequestQueue requestQueue = Volley.newRequestQueue(this );
        JsonArrayRequest jsonArrayRequest = new JsonArrayRequest(Request.Method.GET, url, null, new Response.Listener<JSONArray>() {
            @Override
            public void onResponse(JSONArray response) {

                for(int i=0; i<response.length();i++){
                    try {
                        JSONObject object = response.getJSONObject(i);
                        arrayTuvung.add(new TuVung(
                                object.getString("ID"),
                                object.getString("ANH"),
                                object.getString("TU"),
                                object.getString("PHATAM"),
                                object.getString("NGHIA"),
                                object.getString("TIENG")

                        ));
                    } catch (JSONException e) {
                        e.printStackTrace();
                    }

                }
                adapter1 = new TuVungAdapter(MainTuVung.this, R.layout.show_tu_vung, arrayTuvung);
                lvTuVung.setAdapter(adapter1);
               //adapter1.notifyDataSetChanged();
            }

        }, new Response.ErrorListener() {
            @Override
            public void onErrorResponse(VolleyError error) {
                //Toast.makeText(MainTuVung.this, "Loi !",Toast.LENGTH_SHORT).show();
                ThongBao();
            }
        }
        );
        requestQueue.add(jsonArrayRequest);
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        getMenuInflater().inflate(R.menu.menu_search, menu);
        SearchView searchView = (SearchView) menu.findItem(R.id.menusearch).getActionView();
        searchView.setOnQueryTextListener(new SearchView.OnQueryTextListener() {
            @Override
            public boolean onQueryTextSubmit(String query) {
                adapter1.filter(query.trim());
                return false;
            }

            @Override
            public boolean onQueryTextChange(String newText) {
                adapter1.filter(newText.trim());
                return false;
            }
        });
        return super.onCreateOptionsMenu(menu);
    }

    @Override
    public void beforeTextChanged(CharSequence s, int start, int count, int after) {

    }

    @Override
    public void onTextChanged(CharSequence s, int start, int before, int count) {

    }

    @Override
    public void afterTextChanged(Editable s) {

    }
}
