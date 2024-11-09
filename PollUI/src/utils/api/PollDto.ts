import { PostPollDto } from './../interfaces/PollDto';
import { AxiosResponse } from './../../../node_modules/axios/index.d';
import { GetPollDto } from "../interfaces";
import apiClient from './ClientApi';

export const getPolls = async (): Promise<GetPollDto[]> => {
    const response : AxiosResponse<GetPollDto[]> = await apiClient.get("/polls")
    return Array.isArray(response.data) ? response.data : []
}

export const postPoll = async (postPollDto: PostPollDto ): Promise<GetPollDto> => {
    const response : AxiosResponse<GetPollDto> = await apiClient.get("/polls")
}