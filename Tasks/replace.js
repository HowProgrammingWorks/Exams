'use strict';
// Replace substring with newstr

const replace = (str, substr, newstr) => {
  let searchStr = str;
  let res = '';
  if (substr !== '') {
    let index = searchStr.indexOf(substr);
    while (index !== -1){
      res += searchStr.substring(0, index) + newstr;
      searchStr = searchStr.substring(index + substr.length);
      index = searchStr.indexOf(substr);
    };
  }
  return res + searchStr;
};

require('../Tests/replace.js')(replace);
