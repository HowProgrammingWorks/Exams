// Extract substring between prefix and suffix
'use strict';

const getValueBetween = (string, prefix, suffix) => {
  const substring = '';
  const prefixIndex = string.indexOf(prefix);
  if (prefixIndex === -1) return substring;
  else {
    string = string.substring(prefixIndex + 1);
    if (suffix) {
      const suffixIndex = string.indexOf(suffix);
      if (suffixIndex  === -1) {
        return substring;
      } else {
        string =  string.substring(0, suffixIndex);
      }
    }
  }
  return string;
};

const result = getValueBetween('Hello <username> and bye!', '<', '>');
console.log(result);
