// Extract substring between prefix and suffix
'use strict';

const getValueBetween = (string, prefix, suffix) => {
  let substring = '';
  const prefixIndex = string.indexOf(prefix);
  const suffixIndex = string.indexOf(suffix);
  if (prefixIndex !== -1 && suffixIndex  !== -1) {
    const lengthSubstring = suffixIndex - prefixIndex - 1;
    substring = string.substring(prefixIndex + 1).substring(0, lengthSubstring);
  }
  return substring;
};

const result = getValueBetween('Hello <username> and bye!', '<', '>');
console.log(result);
