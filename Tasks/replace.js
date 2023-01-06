'use strict';
// Replace substring with newStr

const replace = (str, substr, newStr) => {
  if (substr === '') {
    return str;
  }

  let source = str;
  let res = '';

  while (true) {
    const index = source.indexOf(substr);
    if (index === -1) {
      return res + source;
    }

    const start = source.substring(0, index);
    source = source.substring(index + substr.length, source.length);
    res += start + newStr;
  }

};

require('../Tests/replace.js')(replace);
