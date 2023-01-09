'use strict';
// Replace substring with newstr

const replace = (str, substr, newstr) =>
  substr ? str.replaceAll(substr, newstr) : str;

require('../Tests/replace.js')(replace);
