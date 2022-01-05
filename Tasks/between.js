// Extract substring between prefix and suffix
'use strict';

const extract = (str, prefix, suffix) => {

  let index = str.indexOf(prefix);
  if (index !== -1) {

    let ilsum = index + prefix.length;
    str = str.substring(ilsum);
    index = str.indexOf(suffix);

    if (index !== -1) {
      str = str.substring(0, index);
    } else str = "wrong";

  } else str = "wrong";

  return str;
};

const result = extract('Hello <username> and bye!', '<', '>');
console.log(result);

