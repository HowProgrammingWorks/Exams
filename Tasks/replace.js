'use strict';
// Replace substring with newstr

const Replace = (str, substr, newstr) =>
  substr.length ? str.replace(new RegExp(substr, 'g'), newstr) : str;

require('../Tests/replace.js')(Replace);
