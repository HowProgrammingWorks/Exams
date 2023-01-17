// Extract substring between prefix and suffix

const getValueBetween = (str, p, s) => {
  let value;
  const prefixStartIndex = str.indexOf(p);

  if (prefixStartIndex === -1) {
    return "";
  }

  const prefixEndIndex = prefixStartIndex + p.length;
  value = str.substring(prefixEndIndex);

  if (value) {
    const suffixIndex = value.indexOf(s);

    if (suffixIndex === -1) {
      return "";
    } else {
      value = value.substring(0, suffixIndex);
    }
  }
  return value;
};


require("../Tests/between.js")(getValueBetween);
