// Extract substring between prefix and suffix
'use strict';

const getValueBetween = (string, prefix, suffix) => {
  const substring = '';
  const prefixIndex = string.indexOf(prefix);
  const suffixIndex = string.indexOf(suffix);
  const lengthSubstring = suffixIndex - prefixIndex - 1;
  if (prefixIndex !== -1 || suffixIndex  !== -1) {
    string = string.substring(prefixIndex + 1);
    string = string.substring(0, lengthSubstring);
  }
  return string;
};

const result = getValueBetween('Hello <username> and bye!', '<', '>');
console.log(result);
