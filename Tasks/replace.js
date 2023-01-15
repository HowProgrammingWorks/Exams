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

    const newString =
      startOfString + newstr + str.substring(index + substr.length, str.length);

    return replaceSubstring(newString, substr, newstr);
  }
};

require("../Tests/replace.js")(replaceSubstring);
