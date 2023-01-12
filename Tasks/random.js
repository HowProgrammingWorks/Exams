'use strict';

// Generate random integer value in given range

const random = (min, max = min) => {
    return min + Math.floor(Math.random() * (max - min + 1));
};

require('../Tests/random.js')(random);
