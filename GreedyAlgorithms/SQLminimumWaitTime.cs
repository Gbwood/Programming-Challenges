//elements of programming interview 
/// <summary>
/// Database has to respond to a set of sql queries. Service time is known in advance. 
/// Queries must be done one at a time in any order. Time it waits is called it's waiting time. Given the time it takes to complete a query. Give a schedule that minimizes the total wait time.
/// </summary>
/// <param name="jobs"></param>
/// <returns></returns>

public int MinimizeWait(int[] jobs)
{
	Array.sort(jobs); //look up
	int totalWait = 0;
	int[] queueLength = new int[jobs.length];
	

	queueLength[0] = jobs[0];
	for (int i = 1; i < jobs.Length -1; i++)
    {
		queueLength[i] = jobs[i] + jobs[i-1];
    }
	foreach (int num in queueLength)
    {
		totalWait += num;
    }
	return totalWait;
}