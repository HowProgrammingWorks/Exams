// Filter array by type name

// Step 5
// Use Array.prototype.filter()

'use strict';

const filter = (array, type) => {
  const filtered = array.filter((element) => typeof element === type);
  return filtered;
};

require('../Tests/filter.js')(filter);
