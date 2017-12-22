package com.example.thuanduy.trochoi;

import android.support.v7.app.AlertDialog;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.support.v7.widget.SearchView;
import android.text.Editable;
import android.text.TextWatcher;
import android.view.Menu;
import android.widget.ListView;
import android.widget.TextView;
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

public class Mainsearch extends AppCompatActivity  implements TextWatcher{
    String urlGetData="http://thuanduy73h1.000webhostapp.com/demo.php";
    ListView lvTu;
    ArrayList<Tu> arrayTu;
    TuAdapter  adapter;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_mainsearch);
        MainActivity.mediaPlayer.stop();
        lvTu =(ListView) findViewById(R.id.LVtu);
        arrayTu = new ArrayList<>();
        adapter = new TuAdapter(this, R.layout.show_tu,arrayTu);
        lvTu.setAdapter(adapter);
        GetData(urlGetData);
    }
    private void ThongBao(){
        AlertDialog.Builder alertDialog = new AlertDialog.Builder(this);
        alertDialog.setTitle("Lỗi");
        alertDialog.setMessage("Đã xãy ra lỗi !");
        alertDialog.show();
    }
    private void GetData(String url){
        RequestQueue requestQueue = Volley.newRequestQueue(this );
        JsonArrayRequest jsonArrayRequest = new JsonArrayRequest(Request.Method.GET, url, null, new Response.Listener<JSONArray>() {
            @Override
            public void onResponse(JSONArray response) {
                arrayTu.clear();
                for(int i=0; i<response.length();i++){
                    try {
                        JSONObject object = response.getJSONObject(i);
                        arrayTu.add(new Tu(
                                object.getInt("ID"),
                                object.getString("WORD"),
                                object.getString("PRONOUNCE"),
                                object.getString("DETAIL"),
                                object.getString("LINK")
                        ));
                    } catch (JSONException e) {
                        e.printStackTrace();
                    }

                }
                adapter = new TuAdapter(Mainsearch.this, R.layout.show_tu, arrayTu);
                lvTu.setAdapter(adapter);
                //adapter.notifyDataSetChanged();
            }

        }, new Response.ErrorListener() {
            @Override
            public void onErrorResponse(VolleyError error) {
                //Toast.makeText(Mainsearch.this, "Loi !",Toast.LENGTH_SHORT).show();
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
                adapter.filter(query.trim());
                return false;
            }

            @Override
            public boolean onQueryTextChange(String newText) {
                adapter.filter(newText.trim());
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
