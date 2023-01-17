// Extract substring between prefix and suffix

const getValueBetween = (str, p, s) => {
  let value;
  const prefixStartIndex = str.indexOf(p);

  if (prefixStartIndex === -1) return "";

  const prefixEndIndex = prefixStartIndex + p.length;
  value = str.substring(prefixEndIndex);
  
  const suffixStartIndex = value.indexOf(s);

  if (suffixStartIndex === -1) return "";
  value = value.substring(0, suffixStartIndex);

  return value;
};

require("../Tests/between.js")(getValueBetween);
