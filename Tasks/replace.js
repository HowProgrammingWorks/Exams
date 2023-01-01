'use strict';
// Replace substring with newStr

replace = (str, substr, newStr) => {
  if (substr === '') return str;
  else {
    let src = str;
    let res = '';
    while (true) {
      const index = src.indexOf(substr);
      if (index === -1) return res + src;
      else {
        const start = src.substring(0, index);
        src = src.substring(index + substr.length, src.length);
        res += start + newStr;
      }
    };
  }
};

require('../Tests/replace.js')(replace);
