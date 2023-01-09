'use strict';
// Replace substring with newstr

const replace = (str, substr, newstr) => {
  let res = '';
  const substrLen = substr.length;
  if (substrLen) {
    let substrIndex = str.indexOf(substr);
    while (substrIndex !== -1){
      res += str.substring(0, substrIndex) + newstr;
      str = str.substring(substrIndex + substrLen);
      substrIndex = str.indexOf(substr);
    };
  }
  return res + str;
};

require('../Tests/replace.js')(replace);
