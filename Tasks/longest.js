// Find longest string

// Step 2.
// edit Comparison
// eidt naming
'use strict';


const longest = (line = []) => {
  let selected = ' ';
  for (let item of line) {
    if(item.length > selected.length)
    selected = item;
  }
  return !isNaN(selected) ? 'Not found' : selected;
};

require('../Tests/longest.js')(longest);