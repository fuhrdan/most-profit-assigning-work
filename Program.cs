//*****************************************************************************
//** .826 Most Profit Assigning Work Leetcode                                **
//** I started this problem set with a straight forward walkthrough, then    **
//** realized I was on leetcode, so the answer would utilize a hash table    **
//** then the real world interruptec, so I had to throw together a quick     **
//** solution.  This is my C code.  It doesn't work, but needs a little work **
//** to get there.  Then it will be in the bototm section for speed.         **
//** This is a really good exercise, I just didn't have time to finish. -Dan **
//*****************************************************************************

int maxProfitAssignment(int* difficulty, int difficultySize, int* profit, int profitSize, int* worker, int workerSize) {
    int retNum = 0;
    int* prof = (int *)malloc(100001 * sizeof(int));
    int max = 0;
    for(int i = 0; i < profitSize; i++)
    {
        if(prof[difficulty[i]] > profit[i])
        {
            prof[difficulty[i]] = prof[difficulty[i]];
        }
        else
        {
            prof[difficulty[i]] = profit[i];
        }
        if (max < difficulty[i])
            max = difficulty[i];
    }
    for (int j = 1; j < max; j++)
    {
        if(prof[j] > prof[j-1])
        {
            prof[j] = prof[j];
        }
        else
        {
            prof[j] = prof[j-1];
        }
    }
    for ( int k = worker[0]; k < worker[workerSize-1]; k++)
    {
        retNum = retNum + prof[k];
    }
    return retNum;
}