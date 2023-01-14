// Return an array without duplicates
'use strict';

const deduplicate = data => {
  const A = new Set();
  let w = 0;
  data.forEach((a) => {
    if (A.has(a)) {
      data.splice(w, 1);
    }
    else {
      A.add(a);
    };
    w++;
  });
  return data;
}

require('../Tests/distinct.js')(deduplicate);
