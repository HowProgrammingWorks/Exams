'use strict';
// Replace substring with newstr

const replace = (str, substr, newstr) => {
  if (substr === '') {
    return str;
  } else {
    let searchStr = str;
    let res = '';
    do {
      const index = str.indexOf(substr);
      if (index === -1) {
        return res + searchStr;
      } else {
        const start = searchStr.substring(0, index);
        searchStr = searchStr.substring(index + substr.length, searchStr.length);
        res += start + newstr;
      }
    } while (true);
  }
};

require('../Tests/replace.js')(replace);
