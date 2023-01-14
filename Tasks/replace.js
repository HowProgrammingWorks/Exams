'use strict';
// Replace substring with newstr

const replaceSubString = (string, subString, newString) => {
  if (subString === '') {
    return string;
  } else {
    let changeString = string;
    let res = '';
    while (true) {
      const stringIndex = changeString.indexOf(subString);
      if (stringIndex === -1) {
        return res + changeString;
      } else {
        const start = changeString.substring(0, stringIndex);
        changeString = changeString.substring(stringIndex + subString.length, changeString.length);
        res += start + newString;
      }
    }
  }
};

require('../Tests/replace.js')(replaceSubString);
