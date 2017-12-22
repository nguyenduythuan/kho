package com.example.thuanduy.trochoi;

import android.content.Intent;

/**
 * Created by thuan on 28/11/2017.
 */

public class TuVung {
    private String Id;
    private String Anh;
    private String Tu;
    private String PhatAm;
    private String Nghia;
    private String Tieng;

    public TuVung(String id, String anh, String tu, String phatAm, String nghia, String tieng) {
        Id = id;
        Anh = anh;
        Tu = tu;
        PhatAm = phatAm;
        Nghia = nghia;
        Tieng=tieng;
    }

    public String getId() {
        return Id;
    }

    public void setId(String id) {
        Id = id;
    }

    public String getAnh() {
        return Anh;
    }

    public void setAnh(String anh) {
        Anh = anh;
    }

    public String getTu() {
        return Tu;
    }

    public void setTu(String tu) {
        Tu = tu;
    }

    public String getPhatAm() {
        return PhatAm;
    }

    public void setPhatAm(String phatAm) {
        PhatAm = phatAm;
    }

    public String getNghia() {
        return Nghia;
    }

    public void setNghia(String nghia) {
        Nghia = nghia;
    }

    public String getTieng() {
        return Tieng;
    }

    public void setTieng(String tieng) {
        Tieng = tieng;
    }
}
