'use strict';
// Replace substring with newstr

const replaceSubString = (string, subString, newString) => {
  if (subString === '') {
    return string;
  }
  let changeString = string;
  let accumulator = '';
  while (true) {
    const index = changeString.indexOf(subString);
    if (index === -1) {
      return accumulator + changeString;
    }
    const start = changeString.substring(0, index);
    changeString = changeString.substring(index + subString.length, changeString.length);
    accumulator += start + newString;
  }
};

require('../Tests/replace.js')(replaceSubString);
