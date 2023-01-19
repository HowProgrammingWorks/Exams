'use strict';
// Replace substring with newstr

const replace = (str, substr, newstr) => {
  if (
    typeof str !== 'string' ||
    typeof substr !== 'string' ||
    typeof newstr !== 'string'
  ) {
    throw new Error('str, substr or newstr are not a String');
  }

  if (substr === '') {
    return str;
  }

  let result = str;

  do {
    const startIndex = result.indexOf(substr);

    if (startIndex === -1) {
      return result;
    }

    const endIndex = startIndex + substr.length;
    const startString = result.substring(0, startIndex);
    const endString = endIndex > result.length ?
      '' : result.substring(endIndex);
    result = startString + newstr + endString;
  } while (true);
};

require('../Tests/replace.js')(replace);
