// Extract substring between prefix and suffix

const getValueBetween = (str, pref, suff) => {
  let index = str.indexOf(pref);
  if (index === -1) return '';
  else {
    str = str.substring(i + pref.length);
    index = str.indexOf(suff);
    return (suff ? (index === -1 ? '' : str.substring(0, index)) : str);
  }
};

require('../Tests/between.js')(getvaluebetween);
