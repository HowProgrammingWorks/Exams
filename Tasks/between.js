// Extract substring between prefix and suffix
'use strict';

const getValueBetween = (string, firstSymbol, secondSymbol) => {
  let index = string.indexOf(firstSymbol);
  if (index === -1) return '';
  else {
    const leftPosition = index + firstSymbol.length;
    string = string.substring(leftPosition);
    if (secondSymbol) {
      index = string.indexOf(secondSymbol);
      if (index === -1) {
        return '';
      } else {
        string = string.substring(0, index);
      }
    }
  }
  return string;
};

require('../Tests/between.js')(getValueBetween);
