// Extract substring between prefix and suffix
'use strict';

const getValueBetween = (string, prefix, suffix) => {
  const prefixIndex = string.indexOf(prefix);
  if (prefixIndex === -1) return '';
  else {
    const nextStringIndex = prefixIndex + prefix.length;
    string =  string.substring(nextStringIndex);
    if (suffix) {
      const suffixIndex = string.indexOf(suffix);
      if (suffixIndex  === -1) {
        return '';
      } else {
        string =  string.substring(0, suffixIndex);
      }
    }
  }
  return string;
};

const result = getValueBetween('Hello <username> and bye!', '<', '>');
console.log(result);
