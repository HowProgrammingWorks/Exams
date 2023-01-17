// Extract substring between prefix and suffix

const getValueBetween = (str, p, s) => {
  const prefixStartIndex = str.indexOf(p);
  const prefixEndIndex = prefixStartIndex + p.length;
  const suffixStartIndex = str.indexOf(s);

  if ([prefixStartIndex, suffixStartIndex].includes(-1)) {
    return "";
  }
  return str.slice(prefixEndIndex, suffixStartIndex);
};
require("../Tests/between.js")(getValueBetween);
