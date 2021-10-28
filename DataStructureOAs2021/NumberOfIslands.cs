namespace DataStructureOAs2021
{
    public class NumberOfIslands
    {
        private bool[,] _store;
        private int _islands = 0;
        
        public int NumIslands(char[][] grid) {
            _store = new bool[grid.Length,grid[0].Length];
            var i=0;
            for(;i<grid.Length;i++){
                for(var j=0;j<grid[0].Length;j++)
                {
                    if (_store[i, j] || grid[i][j] != '1') continue;
                    
                    _islands++;
                    CountIslands(grid,i,j);
                }
            }
        
            return _islands;
        }

        private void CountIslands(char[][] grid,int r,int c){
            if(r<0 || r>=grid.Length || c<0 || c>=grid[0].Length || _store[r,c] || grid[r][c]=='0') return;
        
            _store[r,c]=true;
        
            CountIslands(grid,r,c-1);
            CountIslands(grid,r-1,c);
            CountIslands(grid,r,c+1);
            CountIslands(grid,r+1,c);
        
        }
    }
}