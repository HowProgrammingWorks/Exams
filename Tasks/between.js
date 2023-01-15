// Extract substring between prefix and suffix

const getvaluebetween = (str, p, s) => {
  let i = str.indexOf(p);
  if (i === -1) return '';
  else {
    str = str.substring(i + p.length);
    if (s) {
      i = str.indexOf(s);
      return (i === -1 ? '' : str.substring(0, i));
    }
  }
  return str;
};

require('../Tests/between.js')(getvaluebetween);
