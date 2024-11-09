export interface GetVoteDto extends PostVoteDto{
    id: number;
    pollId: number;
  }
  
export interface PostVoteDto {
    optionId: number;
    voterEmail: string;
  }