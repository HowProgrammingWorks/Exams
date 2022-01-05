// Extract substring between prefix and suffix
'use strict';

const extract = (str, prefix, suffix) => {

  return str.substring(str.indexOf(prefix)+prefix.length, str.indexOf(suffix));
};

const result = extract('Hello <username> and bye!', '<', '>');
console.log(result);
