// Replace substring with newstr
"use strict";

const replaceSubstring = (str, substr, newstr) => {
  if (substr === "") {
    return str;
  }
  src = str;
  res = "";
  do {
    const _index = src.indexOf(substr);
    if (_index === -1) {
      return res + src;
    } else {
      const start = src.substring(0, _index);
      src = src.substring(_index + substr.length, src.length);
      res += start + newstr;
    }
  } while (true);
};

require("../Tests/replace.js")(replaceSubstring);
