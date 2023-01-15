// Replace substring with newstr
"use strict";

const replaceSubstring = (str, substr, newstr) => {
  if (substr === "") {
    return str;
  }
  let oldString = str;
  let newString = "";
  do {
    const index = oldString.indexOf(substr);
    if (index === -1) {
      return newString + oldString;
    } else {
      const startOfString = oldString.substring(0, index);
      oldString = oldString.substring(index + substr.length, oldString.length);
      newString += startOfString + newstr;
    }
  } while (true);
};

require("../Tests/replace.js")(replaceSubstring);
