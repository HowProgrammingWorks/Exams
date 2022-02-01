// Extract substring between prefix and suffix

getvaluebetween = (str, p, s) => {
  i = str.indexOf(p);
  if (i === -1) return '';
  else {
    k = i + p.length;
    str = str.substring(k);
    if (s) {
      i = str.indexOf(s);
      if (i === -1) {
        return '';
      } else {
        str = str.substring(0, i);
      }
    }
  }
  return str;
};

require('../Tests/between.js')(getvaluebetween);
