// Extract substring between prefix and suffix
'use strict';

const extract = (str, pref, suf) => {
  let index = str.indexOf(pref);
  if (index !== -1) {
    let ipref = index + pref.length;
    str = str.substring(ipref);
    index = str.indexOf(suf);

    if (index !== -1) {
      str = str.substring(0, index);
    } else {
      str = 'wrong';
    }
  } else {
    str = 'wrong';
  }
  return str;
};

const result = extract('Hello <username> and bye!', '<', '>');
console.log(result);
