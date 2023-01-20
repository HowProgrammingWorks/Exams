
i = str.indexOf(p);
if (i == -1) return;
else {
    k = i + p.length;
    str = str.substring(k);
    i = str.indexOf(s);
    if (i == -1) return;
    else {
        str = str.substring(0, i);
    }
}