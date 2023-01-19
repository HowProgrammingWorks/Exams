'use strict';
// Replace substring with newstr

const replace = (str, substr, newstr) => {
  if (substr === '') {
    return str;
  }

  let src = str;
  let result = '';

  do {
    const startIndex = src.indexOf(substr);

    if (startIndex === -1) {
      return result + src;
    }

    const start = src.substring(0, startIndex);
    src = src.substring(startIndex + substr.length, src.length);
    result += start + newstr;
  } while (true);
};

require('../Tests/replace.js')(replace);
