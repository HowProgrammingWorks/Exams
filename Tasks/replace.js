'use strict';
// Replace substring with newstr

const replace = (str, substr, newstr) => {
  let res = '';
  const substrLen = substr.length;
  if (substrLen) {
    let index = str.indexOf(substr);
    while (index !== -1){
      res += str.substring(0, index) + newstr;
      str = str.substring(index + substrLen);
      index = str.indexOf(substr);
    };
  }
  return res + str;
};

require('../Tests/replace.js')(replace);
