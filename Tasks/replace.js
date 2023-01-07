'use strict';
// Replace substring with newstr

const replace = (str, substr, newstr) => {
  let searchStr = str;
  let res = '';
  if (substr !== '') {
    let index = searchStr.indexOf(substr);
    while (index !== -1){
      const start = searchStr.substring(0, index);
      searchStr = searchStr.substring(index + substr.length, searchStr.length);
      res += start + newstr;
      index = searchStr.indexOf(substr);
    };
  }
  return res + searchStr;
};

require('../Tests/replace.js')(replace);
