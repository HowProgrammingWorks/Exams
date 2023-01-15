// Extract substring between prefix and suffix
'use strict';

const getValueBetween = (string, firstSymbol, secondSymbol) => {
  let index = string.indexOf(firstSymbol);
  const leftPosition = index + firstSymbol.length;
  const newString = string.substring(leftPosition);
  index !== -1 ? index = newString.indexOf(secondSymbol) : '';
  const substring = newString.substring(0, index);
  return substring;
};

require('../Tests/between.js')(getValueBetween);
