'use strict';
// Replace substring with newstr

const replace = (str, substr, newstr) => {
  let res = '';
  if (substr !== '') {
    let index = str.indexOf(substr);
    while (index !== -1){
      res += str.substring(0, index) + newstr;
      str = str.substring(index + substr.length);
      index = str.indexOf(substr);
    };
  }
  return res + str;
};

require('../Tests/replace.js')(replace);
