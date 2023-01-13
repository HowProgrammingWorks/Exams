// Find longest string

// used const instead of let in line 9
'use strict';


const longest = (line = []) => {
  let selected = ' ';
  for (const item of line) {
    if (item.length > selected.length)
      selected = item;
  }
  return !isNaN(selected) ? 'Not found' : selected;
};

require('../Tests/longest.js')(longest);