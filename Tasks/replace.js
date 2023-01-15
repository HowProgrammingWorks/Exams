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
    const firstPartOfString = str.substring(0, index) + newstr;
    const secondPartOfString = str.substring(index + substr.length, str.length);

    const newString = firstPartOfString + secondPartOfString;
    
    return replaceSubstring(newString, substr, newstr);
  }
};

require("../Tests/replace.js")(replaceSubstring);
