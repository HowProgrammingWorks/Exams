// Extract substring between prefix and suffix
"use strict";

const GetValueBetween = (string, prefix, suffix) => {
  let result = "";
  const prefixIndex = string.indexOf(prefix);
  const suffixIndex = suffix ? string.indexOf(suffix) : string.length;
  if (prefixIndex === -1 || suffixIndex === -1)
    return result;
  const excludedPrefixIndex = prefixIndex + prefix.length;
  result = string.substring(excludedPrefixIndex, suffixIndex);
  return result;
};

const valueBetween = GetValueBetween("Hello <username> and bye!", "<", ">");
console.log(valueBetween);
