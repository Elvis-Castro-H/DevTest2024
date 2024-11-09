export interface GetPollDto{
  id: number;
  name: string
  options: GetOptionDto[];
}

export interface PostPollDto {
  name: string;
  options: PostOptionDto[];
}



