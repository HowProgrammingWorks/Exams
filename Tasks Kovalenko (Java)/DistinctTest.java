import org.junit.Assert;
import org.junit.Test;
import org.junit.runner.RunWith;
import org.junit.runners.Parameterized;
import java.util.Arrays;
import java.util.Collection;

@RunWith(Parameterized.class)
public class DistinctTest {
    private final Object[] inputData;
    private final Object[] expectedData;

    public DistinctTest(Object[] inputData, Object[] expectedData) {
        this.inputData = inputData;
        this.expectedData = expectedData;
    }

    @Parameterized.Parameters
    public static Collection cases(){
        return Arrays.asList(new Object[][][]{
                {{1, 2, 1, 3, 1, 4}, {1, 2, 3, 4}},
                {{1, 2, -1, 3, 0, 4}, {1, 2, -1, 3, 0, 4}},
                {{1}, {1}},
                {{1, 1, 1}, {1}},
                {{0}, {0}},
                {{0, 0, 0}, {0}},
                {{0, 0, 0, 0}, {0}},
                {{}, {}}
        });
    }

    @Test
    public void fullTest(){
        Assert.assertEquals(expectedData, Distinct.distinct(inputData).toArray());
    }
}