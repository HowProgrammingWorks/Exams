// Replace substring with newstr
"use strict";

const replaceSubstring = (str, substr, newstr) => {
  if (substr === "") {
    return str;
  }
  const index = str.indexOf(substr);
  if (index === -1) {
    return str;
  } else {
    const startOfString = str.substring(0, index);
    const oldString = str.substring(index + substr.length, str.length);
    const newString = startOfString + newstr;
    const fullNewSring = newString + oldString;
    return replaceSubstring(fullNewSring, substr, newstr);
  }
};

require("../Tests/replace.js")(replaceSubstring);
