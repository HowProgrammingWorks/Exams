// Extract substring between prefix and suffix
"use strict";

const GetValueBetween = (string, prefix, suffix) => {
  let result = "";
  const prefixIndex = string.indexOf(prefix);
  const suffixIndex = string.indexOf(suffix);
  if (prefixIndex === -1 || (suffix && suffixIndex === -1))
    return "";
  const excludedPrefixIndex = prefixIndex + prefix.length;
  result = string.substring(excludedPrefixIndex);
  result = result.substring(0, suffixIndex);
  return result;
};

const valueBetween = GetValueBetween("Hello <username> and bye!", "<", ">");
console.log(valueBetween);
