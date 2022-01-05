// Extract substring between prefix and suffix
"use strict";

const extract = (str, pref, suf) => {
  let index = str.indexOf(pref);
  const iPref = index + pref.length;
  let tmpStr = str.substring(iPref);

  if (index !== -1) {
    index = tmpStr.indexOf(suf);

    if (index !== -1) {
      tmpStr = tmpStr.substring(0, index);
    } else {
      tmpStr = "wrong";
    }
  } else {
    tmpStr = "wrong";
  }
  return tmpStr;
};

const result = extract("Hello <username> and bye!", "<", ">");
console.log(result);
