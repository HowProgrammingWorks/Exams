// Extract substring between prefix and suffix
'use strict';

const getValueBetween = (string, prefix, suffix) => {
  const ERR = -1;
  let substring = '';
  const prefixIndex = string.indexOf(prefix);
  const suffixIndex = string.indexOf(suffix);
  if (prefixIndex !== ERR && suffixIndex  !== ERR) {
    const firstIndexSubstring = prefixIndex + 1;
    substring = string.substring(firstIndexSubstring, suffixIndex);
  }
  return substring;
};

const result = getValueBetween('Hello <username> and bye!', '<', '>');
console.log(result);
