// Extract substring between prefix and suffix
'use strict';

const getValueBetween = (string, firstSymbol, secondSymbol) => {
  let index = string.indexOf(firstSymbol);
  const leftPosition = index + firstSymbol.length;
  const newString = string.substring(leftPosition);
  index !== -1 ? newString : '';
  index !== -1 ? index = newString.indexOf(secondSymbol) : '';
  const lastString = newString.substring(0, index);
  return lastString;
};

require('../Tests/between.js')(getValueBetween);
