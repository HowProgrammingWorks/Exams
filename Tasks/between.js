// Extract substring between prefix and suffix
'use strict';

const getValueBetween = (string, firstSymbol, secondSymbol) => {
  let index = string.indexOf(firstSymbol);
  const leftPosition = index + firstSymbol.length;
  index !== -1 ? string = string.substring(leftPosition) : '';
  index !== -1 ? index = string.indexOf(secondSymbol) : '';
  string = string.substring(0, index);
  return string;
};

require('../Tests/between.js')(getValueBetween);
