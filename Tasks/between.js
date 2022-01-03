// Extract substring between prefix and suffix
"use strict";

const GetValueBetween = (string, prefix, suffix) => {
  const prefixIndex = string.indexOf(prefix);
  if (prefixIndex === -1)
    return "";
  else {
    const k = prefixIndex + prefix.length;
    let result = string.substring(k);
    if (suffix) {
      const suffixIndex = result.indexOf(suffix);
      if (suffixIndex === -1)
        return "";
      result = result.substring(0, suffixIndex);
    }
  }
  return result;
};

const valueBetween = GetValueBetween("Hello <username> and bye!", "<", ">");
console.log(valueBetween);
