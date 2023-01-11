import org.junit.Assert;
import org.junit.Test;
import org.junit.runner.RunWith;
import org.junit.runners.Parameterized;

import java.util.Arrays;
import java.util.Collection;

@RunWith(Parameterized.class)
public class DistinctTest {
    private final Object[] INPUT_DATA;
    private final Object[] EXPECTED_DATA;

    public DistinctTest(Object[] inputData, Object[] expectedData) {
        this.INPUT_DATA = inputData;
        this.EXPECTED_DATA = expectedData;
    }

    @Parameterized.Parameters
    public static Collection cases() {
        return Arrays.asList(new Object[][][]{
                {{1, 2, 1, 3, 1, 4}, {1, 2, 3, 4}},
                {{1, 2, -1, 3, 0, 4}, {1, 2, -1, 3, 0, 4}},
                {{1}, {1}},
                {{1, 1, 1}, {1}},
                {{0}, {0}},
                {{0, 0, 0}, {0}},
                {{0, 0, 0, 0}, {0}},
                {{}, {}},
                {{"abc", "abc", "aaa", 10, 10, 5}, {"abc", "aaa", 10, 5}},
                {{'t', 'e', 's', 't', '1', '1'}, {'t', 'e', 's', '1'}},
                {{22.5, 22.5, 12.7, 55.9}, {22.5, 12.7, 55.9}}
        });
    }

    @Test
    public void fullTest() {
        Assert.assertEquals(EXPECTED_DATA, Distinct.distinct(INPUT_DATA).toArray());
    }
}